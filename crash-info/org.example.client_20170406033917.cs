S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9032
Date: 2017-04-06 03:39:17+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 9032, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002348
r2   = 0x00000006, r3   = 0xb40e14c0
r4   = 0x00000002, r5   = 0xb40e1000
r6   = 0xb67db09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f09708
r10  = 0xb783fc28, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbee64ec4
lr   = 0xb66d1f18, pc   = 0xb66d0b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     78388 KB
Buffers:     61704 KB
Cached:     286952 KB
VmPeak:     133916 KB
VmSize:     133912 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28312 KB
VmRSS:       28312 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9032 TID = 9032
9032 9033 9836 9837 9847 

Maps Information
aee8e000 af68d000 rw-p [stack:9847]
b0f88000 b0f99000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fa9000 b0fae000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13b0000 b13b8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13ca000 b1bc9000 rw-p [stack:9837]
b1bc9000 b1bca000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bda000 b1bee000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c02000 b1c03000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c13000 b1c16000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c27000 b1c28000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c38000 b1c3a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c4a000 b1c4c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c5c000 b1c6c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c7c000 b1c88000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c9a000 b2499000 rw-p [stack:9836]
b27ca000 b27d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27e4000 b27ea000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27fa000 b2815000 r-xp /opt/usr/apps/org.example.client/bin/client
b296d000 b2a50000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a87000 b2aaf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ac1000 b32c0000 rw-p [stack:9033]
b32c0000 b32c2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32d2000 b32dc000 r-xp /lib/libnss_files-2.20-2014.11.so
b32ed000 b32f6000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3307000 b3318000 r-xp /lib/libnsl-2.20-2014.11.so
b332b000 b3331000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3342000 b3343000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b336b000 b3372000 r-xp /usr/lib/libminizip.so.1.0.0
b3382000 b3387000 r-xp /usr/lib/libstorage.so.0.1
b3397000 b33f6000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b340c000 b3420000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3430000 b3474000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3484000 b348c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b349c000 b34cc000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34df000 b3598000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35ac000 b35ff000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3610000 b362b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b363b000 b36fc000 r-xp /usr/lib/libprotobuf.so.9.0.1
b370f000 b371f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b372f000 b373c000 r-xp /usr/lib/libmdm-common.so.1.0.98
b374d000 b3754000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3764000 b37a5000 r-xp /usr/lib/libmdm.so.1.2.12
b37b5000 b37bd000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37cc000 b37dc000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37fd000 b385d000 r-xp /usr/lib/libasound.so.2.0.0
b386f000 b3872000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3882000 b3885000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3895000 b389a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38aa000 b38ab000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38bb000 b38c6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38da000 b38e1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38f1000 b38f7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3907000 b390c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b391c000 b3937000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3947000 b394e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b395e000 b3961000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3972000 b39a0000 r-xp /usr/lib/libidn.so.11.5.44
b39b0000 b39c6000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39d7000 b39e1000 r-xp /usr/lib/libcares.so.2.1.0
b39f1000 b39fb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a0b000 b3a0d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a1d000 b3a1e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a2e000 b3a32000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a43000 b3a6b000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a7c000 b3aa5000 r-xp /usr/lib/libturbojpeg.so
b3ac5000 b3acb000 r-xp /usr/lib/libgif.so.4.1.6
b3adb000 b3b21000 r-xp /usr/lib/libcurl.so.4.3.0
b3b32000 b3b53000 r-xp /usr/lib/libexif.so.12.3.3
b3b6e000 b3b83000 r-xp /usr/lib/libtts.so
b3b94000 b3b9c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bac000 b3c72000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c92000 b3d8a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da9000 b3e77000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e8e000 b3e90000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ea0000 b3ea6000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eb6000 b3ed9000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eea000 b3eec000 r-xp /usr/lib/libappsvc.so.0.1.0
b3efc000 b3efe000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f0f000 b3f14000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f2b000 b3f2d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f3d000 b3f44000 r-xp /usr/lib/libsensord-share.so
b3f54000 b3f6c000 r-xp /usr/lib/libsensor.so.1.1.0
b3f7d000 b3f80000 r-xp /usr/lib/libXv.so.1.0.0
b3f90000 b3f95000 r-xp /usr/lib/libutilX.so.1.1.0
b3fa5000 b3faa000 r-xp /usr/lib/libappcore-common.so.1.1
b3fba000 b3fc1000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fd4000 b3fd8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe9000 b40c7000 r-xp /usr/lib/libCOREGL.so.4.0
b40e7000 b40ea000 r-xp /usr/lib/libuuid.so.1.3.0
b40fa000 b4111000 r-xp /usr/lib/libblkid.so.1.1.0
b4122000 b4124000 r-xp /usr/lib/libXau.so.6.0.0
b4134000 b417b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b418d000 b4193000 r-xp /usr/lib/libjson-c.so.2.0.1
b41a4000 b41a8000 r-xp /usr/lib/libogg.so.0.7.1
b41b8000 b41da000 r-xp /usr/lib/libvorbis.so.0.4.3
b41ea000 b42ce000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42ea000 b42ed000 r-xp /usr/lib/libEGL.so.1.4
b42fe000 b4304000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4314000 b4316000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4326000 b4333000 r-xp /usr/lib/libGLESv2.so.2.0
b4344000 b43a6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43bb000 b43d3000 r-xp /usr/lib/libmount.so.1.1.0
b43e5000 b43f9000 r-xp /usr/lib/libxcb.so.1.1.0
b4409000 b4410000 r-xp /lib/libcrypt-2.20-2014.11.so
b4448000 b444a000 r-xp /usr/lib/libiri.so
b445a000 b4465000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4476000 b44ac000 r-xp /usr/lib/libpulse.so.0.16.2
b44bd000 b4500000 r-xp /usr/lib/libsndfile.so.1.0.25
b4515000 b452a000 r-xp /lib/libexpat.so.1.5.2
b453c000 b45fa000 r-xp /usr/lib/libcairo.so.2.11200.14
b460e000 b4616000 r-xp /usr/lib/libdrm.so.2.4.0
b4626000 b4629000 r-xp /usr/lib/libdri2.so.0.0.0
b4639000 b4687000 r-xp /usr/lib/libssl.so.1.0.0
b469c000 b46a8000 r-xp /usr/lib/libeeze.so.1.13.0
b46b9000 b46c2000 r-xp /usr/lib/libethumb.so.1.13.0
b46d2000 b46d5000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46e5000 b489c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5687000 b5690000 r-xp /usr/lib/libXi.so.6.1.0
b56a0000 b56a2000 r-xp /usr/lib/libXgesture.so.7.0.0
b56b2000 b56b6000 r-xp /usr/lib/libXtst.so.6.1.0
b56c6000 b56cc000 r-xp /usr/lib/libXrender.so.1.3.0
b56dc000 b56e2000 r-xp /usr/lib/libXrandr.so.2.2.0
b56f2000 b56f4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5705000 b5708000 r-xp /usr/lib/libXfixes.so.3.1.0
b5718000 b5723000 r-xp /usr/lib/libXext.so.6.4.0
b5733000 b5735000 r-xp /usr/lib/libXdamage.so.1.1.0
b5745000 b5747000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5757000 b5839000 r-xp /usr/lib/libX11.so.6.3.0
b584d000 b5854000 r-xp /usr/lib/libXcursor.so.1.0.2
b5864000 b587c000 r-xp /usr/lib/libudev.so.1.6.0
b587e000 b5881000 r-xp /lib/libattr.so.1.1.0
b5891000 b58b1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58b2000 b58b7000 r-xp /usr/lib/libffi.so.6.0.2
b58c8000 b58e0000 r-xp /lib/libz.so.1.2.8
b58f0000 b58f2000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5902000 b59d7000 r-xp /usr/lib/libxml2.so.2.9.2
b59ec000 b5a87000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aa3000 b5aa6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ab6000 b5acf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ae0000 b5af1000 r-xp /lib/libresolv-2.20-2014.11.so
b5b05000 b5b7f000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b94000 b5b96000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ba6000 b5bad000 r-xp /usr/lib/libembryo.so.1.13.0
b5bbd000 b5bc7000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd8000 b5bf0000 r-xp /usr/lib/libpng12.so.0.50.0
b5c01000 b5c24000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c45000 b5c59000 r-xp /usr/lib/libector.so.1.13.0
b5c6a000 b5c82000 r-xp /usr/lib/liblua-5.1.so
b5c93000 b5cea000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cfe000 b5d26000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d37000 b5d4a000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d5b000 b5d95000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5da6000 b5db4000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dc4000 b5dcc000 r-xp /usr/lib/libtbm.so.1.0.0
b5ddc000 b5de9000 r-xp /usr/lib/libeio.so.1.13.0
b5df9000 b5dfb000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e0b000 b5e10000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e20000 b5e37000 r-xp /usr/lib/libefreet.so.1.13.0
b5e49000 b5e69000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e79000 b5e99000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e9b000 b5ea1000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eb1000 b5ec2000 r-xp /usr/lib/libemotion.so.1.13.0
b5ed3000 b5eda000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eea000 b5ef9000 r-xp /usr/lib/libeo.so.1.13.0
b5f0a000 b5f1c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f2d000 b5f32000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f42000 b5f5b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f6b000 b5f88000 r-xp /usr/lib/libeet.so.1.13.0
b5fa1000 b5fe9000 r-xp /usr/lib/libeina.so.1.13.0
b5ffa000 b600a000 r-xp /usr/lib/libefl.so.1.13.0
b601b000 b6100000 r-xp /usr/lib/libicuuc.so.51.1
b611d000 b625d000 r-xp /usr/lib/libicui18n.so.51.1
b6274000 b62ac000 r-xp /usr/lib/libecore_x.so.1.13.0
b62be000 b62c1000 r-xp /lib/libcap.so.2.21
b62d1000 b62fa000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b630b000 b6312000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6324000 b635b000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b636c000 b6457000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b646a000 b64e3000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64f5000 b64fa000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b650a000 b6514000 r-xp /usr/lib/libvconf.so.0.2.45
b6524000 b6526000 r-xp /usr/lib/libvasum.so.0.3.1
b6536000 b6538000 r-xp /usr/lib/libttrace.so.1.1
b6548000 b654b000 r-xp /usr/lib/libiniparser.so.0
b655b000 b6581000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6591000 b6596000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a7000 b65be000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65cf000 b663a000 r-xp /lib/libm-2.20-2014.11.so
b664b000 b6651000 r-xp /lib/librt-2.20-2014.11.so
b6662000 b666f000 r-xp /usr/lib/libunwind.so.8.0.1
b66a5000 b67c9000 r-xp /lib/libc-2.20-2014.11.so
b67de000 b67f7000 r-xp /lib/libgcc_s-4.9.so.1
b6807000 b68e9000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68fa000 b6924000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6935000 b6971000 r-xp /usr/lib/libsystemd.so.0.4.0
b6973000 b69f6000 r-xp /usr/lib/libedje.so.1.13.0
b6a09000 b6a27000 r-xp /usr/lib/libecore.so.1.13.0
b6a47000 b6bce000 r-xp /usr/lib/libevas.so.1.13.0
b6c03000 b6c17000 r-xp /lib/libpthread-2.20-2014.11.so
b6c2b000 b6e5f000 r-xp /usr/lib/libelementary.so.1.13.0
b6e8e000 b6e92000 r-xp /usr/lib/libsmack.so.1.0.0
b6ea2000 b6ea9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb9000 b6ebb000 r-xp /usr/lib/libdlog.so.0.0.0
b6ecb000 b6ece000 r-xp /usr/lib/libbundle.so.0.1.22
b6ede000 b6ee0000 r-xp /lib/libdl-2.20-2014.11.so
b6ef1000 b6f09000 r-xp /usr/lib/libaul.so.0.1.0
b6f1d000 b6f22000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f33000 b6f40000 r-xp /usr/lib/liblptcp.so
b6f52000 b6f56000 r-xp /usr/lib/libsys-assert.so
b6f67000 b6f87000 r-xp /lib/ld-2.20-2014.11.so
b6f98000 b6f9d000 r-xp /usr/bin/launchpad-loader
b74bc000 b789b000 rw-p [heap]
bee45000 bee66000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9032)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66d0b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
03:36:41.653+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:36:41.653+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:36:41.663+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:36:41.663+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:36:41.683+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:36:41.683+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:36:41.693+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7a92870]
04-06 03:36:41.693+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:36:41.693+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7a92870
04-06 03:36:41.693+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:36:41.693+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:36:41.693+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:36:41.693+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:36:41.693+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:36:41.693+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:36:41.693+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:36:41.693+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:37:00.542+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:37:00.542+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:37
04-06 03:37:00.542+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:37"
04-06 03:37:00.542+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:37"
04-06 03:37:00.542+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:37:00.542+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146390550 Time: <font_size=31> </font_size> <font_size=31> 오전 3:37</font_size></font>"
04-06 03:37:31.302+0900 E/PKGMGR_SERVER( 9508): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:37:31.352+0900 E/PKGMGR  ( 9506): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 03:37:31.392+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 03:37:31.392+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 9436
04-06 03:37:31.402+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 03:37:31.412+0900 E/PKGMGR_SERVER( 9508): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9511]
04-06 03:37:33.634+0900 E/PKGMGR_SERVER( 9508): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:37:33.634+0900 E/PKGMGR_SERVER( 9508): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:37:35.736+0900 E/PKGMGR  ( 9597): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 03:37:35.816+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:37:35.866+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 03:37:35.876+0900 E/PKGMGR_SERVER( 9599): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 03:37:35.876+0900 E/PKGMGR  ( 9597): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[95970002]
04-06 03:37:36.026+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 03:37:36.026+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 03:37:36.037+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.037+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.037+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.037+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.037+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 03:37:36.047+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:37:36.047+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:37:36.047+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 03:37:36.047+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.047+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.047+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.047+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.197+0900 W/CERT_SVC_VCORE( 9602): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:37:36.277+0900 E/rpm-installer( 9602): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 03:37:36.277+0900 E/rpm-installer( 9602): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 03:37:36.337+0900 E/PKGMGR_PARSER( 9602): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 03:37:36.357+0900 I/PRIVACY-MANAGER-CLIENT( 9602): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:37:36.357+0900 I/PRIVACY-MANAGER-CLIENT( 9602): SocketClient.cpp: connect(62) > Client connected
04-06 03:37:36.357+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 03:37:36.357+0900 I/PRIVACY-MANAGER-CLIENT( 9602): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 03:37:36.357+0900 E/PKGMGR_CERT( 9602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 03:37:36.367+0900 E/PKGMGR_CERT( 9602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 03:37:36.367+0900 E/PKGMGR_CERT( 9602): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 03:37:36.407+0900 E/rpm-installer( 9602): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 03:37:36.407+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.407+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.407+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.407+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:36.407+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 03:37:36.407+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-06 03:37:36.407+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 03:37:36.417+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 03:37:36.417+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 03:37:36.417+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 03:37:37.638+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:37:38.079+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9602]
04-06 03:37:39.029+0900 E/PKGMGR  ( 9651): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 03:37:39.059+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 03:37:39.069+0900 E/PKGMGR_INFO( 9599): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 03:37:39.079+0900 E/rpm-installer( 9599): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 03:37:39.089+0900 E/PKGMGR_SERVER( 9599): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 03:37:39.089+0900 E/PKGMGR  ( 9651): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[96510002]
04-06 03:37:39.220+0900 E/PKGMGR_INSTALLER( 9653): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 03:37:39.220+0900 E/rpm-installer( 9653): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 03:37:39.240+0900 E/rpm-installer( 9653): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 03:37:39.240+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 03:37:39.240+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:37:39.240+0900 E/rpm-installer( 9653): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 03:37:39.240+0900 E/rpm-installer( 9653): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:37:39.290+0900 W/CERT_SVC_VCORE( 9653): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:37:39.340+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 03:37:39.340+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-06 03:37:39.350+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.350+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.350+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.350+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.360+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:37:39.360+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:37:39.360+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 03:37:39.360+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.360+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.360+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.360+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 03:37:39.580+0900 E/rpm-installer( 9653): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 03:37:39.590+0900 E/PKGMGR_PARSER( 9653): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 03:37:39.590+0900 E/PKGMGR_PARSER( 9653): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 03:37:39.630+0900 I/PRIVACY-MANAGER-CLIENT( 9653): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:37:39.640+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:37:39.850+0900 E/PKGMGR_PARSER( 9653): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 03:37:39.870+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 03:37:39.880+0900 E/PKGMGR_CERT( 9653): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 03:37:39.880+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.880+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 03:37:39.880+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.880+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.880+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.880+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 03:37:39.880+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-06 03:37:39.900+0900 E/rpm-installer( 9653): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:37:39.920+0900 E/rpm-installer( 9653): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 03:37:39.920+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.920+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 03:37:39.920+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.920+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.920+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 03:37:39.920+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:39.920+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-06 03:37:41.642+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:37:41.802+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 03:37:41.802+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 03:37:41.802+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 03:37:41.802+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 03:37:41.802+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 03:37:41.802+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 03:37:41.802+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 03:37:41.812+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:41.812+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:41.812+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:41.812+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:37:41.852+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 03:37:41.862+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9653]
04-06 03:37:41.872+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 03:37:41.882+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 03:37:41.882+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 03:37:41.882+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 03:37:41.882+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 03:37:41.882+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:37:41.892+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 03:37:41.892+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-06 03:37:41.902+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 03:37:41.902+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (131) > Enter
04-06 03:37:41.902+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 03:37:41.902+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 03:37:41.912+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 03:37:41.932+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 03:37:41.942+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 03:37:43.644+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:37:43.644+0900 E/PKGMGR_SERVER( 9599): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:37:46.186+0900 W/AUL     ( 9713): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:37:46.186+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:37:46.196+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:37:46.196+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:37:46.196+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:37:46.196+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9713
04-06 03:37:46.196+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:37:46.206+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:37:46.206+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:37:46.216+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-4)
04-06 03:37:46.327+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9715, appid: org.example.client
04-06 03:37:46.327+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:37:46.347+0900 W/AUL     ( 9713): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9715)
04-06 03:37:47.338+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:37:47.338+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 03:37:49.660+0900 I/abc     ( 9715): abc
04-06 03:37:49.680+0900 I/CAPI_APPFW_APPLICATION( 9715): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:37:50.821+0900 I/CAPI_APPFW_APPLICATION( 9715): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:37:51.341+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(9715)
04-06 03:37:51.341+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9715, appid: org.example.client, status: bg
04-06 03:37:52.933+0900 E/TBM     ( 9715): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:38:00.540+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:38:00.540+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:38
04-06 03:38:00.540+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:38"
04-06 03:38:00.540+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:38"
04-06 03:38:00.540+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:38:00.540+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146369525 Time: <font_size=31> </font_size> <font_size=31> 오전 3:38</font_size></font>"
04-06 03:38:10.430+0900 D/basicui ( 9715): successed to load edc file
04-06 03:38:10.470+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:38:10.470+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:38:10.520+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:38:10.520+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:38:10.520+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:38:10.520+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:38:11.371+0900 I/MY_LOG  ( 9715): change
04-06 03:38:11.411+0900 I/APP_CORE( 9715): appcore-efl.c: __do_app(514) > [APP 9715] Event: RESET State: CREATED
04-06 03:38:11.411+0900 I/CAPI_APPFW_APPLICATION( 9715): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:38:11.441+0900 W/APP_CORE( 9715): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:38:11.441+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:38:11.711+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:38:11.711+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:38:11.711+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:38:11.721+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:38:11.721+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:38:11.721+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:38:11.721+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9715) status(3)
04-06 03:38:11.721+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:38:11.721+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:38:11.721+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9715)
04-06 03:38:11.721+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9715, appid: org.example.client, status: fg
04-06 03:38:11.731+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:38:11.731+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:38:11.731+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:38:11.731+0900 I/APP_CORE( 9715): appcore-efl.c: __do_app(514) > [APP 9715] Event: RESUME State: CREATED
04-06 03:38:11.751+0900 I/APP_CORE( 9715): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:38:11.751+0900 I/APP_CORE( 9715): appcore-efl.c: __do_app(625) > [APP 9715] Initial Launching, call the resume_cb
04-06 03:38:11.751+0900 I/CAPI_APPFW_APPLICATION( 9715): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:38:12.082+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9715) status(0)
04-06 03:38:12.782+0900 I/MY_LOG  ( 9715): Button pressed
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9715) : db/ise/keysound error
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:38:12.872+0900 E/VCONF   ( 9715): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:38:12.922+0900 I/MY_LOG  ( 9715): Button unpressed
04-06 03:38:16.716+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: MEM_FLUSH State: PAUSED
04-06 03:38:56.045+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:38:56.105+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:38:56.115+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:38:56.115+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:38:56.115+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:38:56.145+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:38:56.145+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:38:56.155+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:38:56.155+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:38:56.155+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:38:56.155+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:38:56.155+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:38:56.155+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:38:56.155+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:38:56.155+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:38:56.155+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:38:56.165+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:38:56.195+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:38:56.195+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:38:56.205+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:38:56.205+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:38:56.215+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:38:56.235+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b6d6e0]
04-06 03:38:56.235+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:38:56.235+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b6d6e0
04-06 03:38:56.235+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:38:56.245+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:38:56.245+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:38:56.245+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:38:56.245+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:39:00.539+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:39:00.539+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:39
04-06 03:39:00.539+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:39"
04-06 03:39:00.539+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:39"
04-06 03:39:00.549+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:39:00.549+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146389451 Time: <font_size=31> </font_size> <font_size=31> 오전 3:39</font_size></font>"
04-06 03:39:09.988+0900 E/PKGMGR_SERVER( 9777): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:39:10.038+0900 E/PKGMGR  ( 9775): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 03:39:10.068+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 03:39:10.068+0900 E/AUL_AMD (  610): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 9715
04-06 03:39:10.078+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 03:39:10.088+0900 E/PKGMGR_SERVER( 9777): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9780]
04-06 03:39:12.300+0900 W/AUL     ( 9829): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:39:12.300+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:39:12.310+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:39:12.320+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:39:12.320+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:39:12.320+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9829
04-06 03:39:12.320+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:39:12.330+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:39:12.330+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:39:12.330+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:39:12.330+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:39:12.330+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:39:12.350+0900 I/abc     ( 9032): abc
04-06 03:39:12.350+0900 I/CAPI_APPFW_APPLICATION( 9032): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:39:12.350+0900 I/CAPI_APPFW_APPLICATION( 9032): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:39:12.370+0900 E/TBM     ( 9032): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:39:12.431+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9032, appid: org.example.client
04-06 03:39:12.431+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:39:12.431+0900 W/AUL     ( 9829): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9032)
04-06 03:39:12.631+0900 D/basicui ( 9032): successed to load edc file
04-06 03:39:12.641+0900 E/PKGMGR_SERVER( 9777): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:39:12.641+0900 E/PKGMGR_SERVER( 9777): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:39:12.681+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:39:12.681+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:39:12.711+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:39:12.711+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:39:12.711+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:39:12.711+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:39:12.761+0900 I/MY_LOG  ( 9032): change
04-06 03:39:12.811+0900 I/APP_CORE( 9032): appcore-efl.c: __do_app(514) > [APP 9032] Event: RESET State: CREATED
04-06 03:39:12.811+0900 I/CAPI_APPFW_APPLICATION( 9032): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:39:12.821+0900 E/EFL     ( 9032): edje<9032> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:39:12.821+0900 E/EFL     ( 9032): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:39:12.821+0900 E/EFL     ( 9032): edje<9032> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:39:12.821+0900 E/EFL     ( 9032): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:39:12.831+0900 E/EFL     ( 9032): edje<9032> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:39:12.831+0900 E/EFL     ( 9032): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:39:12.831+0900 W/APP_CORE( 9032): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 03:39:12.831+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:39:12.941+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:39:12.941+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:39:12.941+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:39:12.941+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:39:12.941+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:39:12.941+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:39:12.951+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9032) status(3)
04-06 03:39:12.951+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:39:12.951+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:39:12.951+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9032)
04-06 03:39:12.951+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9032, appid: org.example.client, status: fg
04-06 03:39:12.951+0900 I/APP_CORE( 9032): appcore-efl.c: __do_app(514) > [APP 9032] Event: RESUME State: CREATED
04-06 03:39:12.961+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:39:12.961+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:39:12.961+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:39:12.971+0900 I/APP_CORE( 9032): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:39:12.971+0900 I/APP_CORE( 9032): appcore-efl.c: __do_app(625) > [APP 9032] Initial Launching, call the resume_cb
04-06 03:39:12.971+0900 I/CAPI_APPFW_APPLICATION( 9032): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:39:13.321+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9032) status(0)
04-06 03:39:13.512+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:39:13.512+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 9032.
04-06 03:39:13.512+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2060
04-06 03:39:14.282+0900 I/UXT     ( 9843): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:39:16.925+0900 E/EFL     ( 9032): ecore_x<9032> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215476292
04-06 03:39:16.925+0900 I/MY_LOG  ( 9032): Button pressed
04-06 03:39:17.005+0900 E/EFL     ( 9032): ecore_x<9032> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215476369
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9032) : db/ise/keysound error
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:39:17.015+0900 E/VCONF   ( 9032): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:39:17.065+0900 I/MY_LOG  ( 9032): Button unpressed
04-06 03:39:17.205+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:39:17.205+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9032 pgid = 9032
04-06 03:39:17.205+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(9032)
04-06 03:39:17.225+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:39:17.225+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:39:17.225+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:39:17.225+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:39:17.225+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:39:17.255+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:39:17.255+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:39:17.255+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:39:17.255+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 9032
04-06 03:39:17.255+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[9032] terminate event is forwarded
04-06 03:39:17.255+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:39:17.255+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 9032, ]
04-06 03:39:17.255+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:39:17.255+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:39:17.255+0900 I/Tizen::App( 1231): (512) > Not registered pid(9032)
04-06 03:39:17.255+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:39:17.255+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:39:17.255+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9032
04-06 03:39:17.255+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9032
04-06 03:39:17.265+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2064
04-06 03:39:17.275+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:39:17.285+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:39:17.285+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:39:17.285+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:39:17.285+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:39:17.285+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 9032.
04-06 03:39:17.295+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:39:17.305+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:39:17.345+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:39:17.345+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:39:17.345+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:39:17.365+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:39:17.365+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:39:17.365+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:39:17.375+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:39:17.375+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:39:17.375+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:39:17.405+0900 W/CRASH_MANAGER( 9851): worker.c: worker_job(1199) > 0609032636c69149141755
