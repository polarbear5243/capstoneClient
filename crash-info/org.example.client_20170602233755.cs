S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 23171
Date: 2017-06-02 23:37:55+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 23171, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00005a83
r2   = 0x00000006, r3   = 0xb40e14c0
r4   = 0x00000002, r5   = 0xb40e1000
r6   = 0xb67db09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f09708
r10  = 0xb894c468, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec87c24
lr   = 0xb66d1f18, pc   = 0xb66d0b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     49700 KB
Buffers:     83588 KB
Cached:     272004 KB
VmPeak:     135276 KB
VmSize:     133964 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28892 KB
VmRSS:       28208 KB
VmData:      46048 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 23171 TID = 23171
23171 23173 24300 24301 24310 

Maps Information
af22e000 afa2d000 rw-p [stack:24310]
b1399000 b13a1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13b3000 b1bb2000 rw-p [stack:24301]
b1bb2000 b1bb3000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc3000 b1bd7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1beb000 b1bec000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bfc000 b1bff000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c10000 b1c11000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c21000 b1c23000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c33000 b1c35000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c45000 b1c55000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c65000 b1c71000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c83000 b2482000 rw-p [stack:24300]
b27b3000 b27ba000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27cd000 b27d3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e3000 b2814000 r-xp /opt/usr/apps/org.example.client/bin/client
b296d000 b2a50000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a87000 b2aaf000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ac1000 b32c0000 rw-p [stack:23173]
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
b8547000 b896d000 rw-p [heap]
bec68000 bec89000 rw-p [stack]
bec68000 bec89000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23171)
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
LL
06-02 23:37:40.235+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.235+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.415+0900 W/CERT_SVC_VCORE(24188): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-02 23:37:40.516+0900 E/rpm-installer(24188): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-02 23:37:40.516+0900 E/rpm-installer(24188): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-02 23:37:40.576+0900 E/PKGMGR_PARSER(24188): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-02 23:37:40.586+0900 I/PRIVACY-MANAGER-CLIENT(24188): SocketClient.cpp: SocketClient(37) > Client created
06-02 23:37:40.586+0900 I/PRIVACY-MANAGER-CLIENT(24188): SocketClient.cpp: connect(62) > Client connected
06-02 23:37:40.586+0900 I/PRIVACY-MANAGER-SERVER(  916): SocketService.cpp: mainloop(230) > Got incoming connection
06-02 23:37:40.596+0900 I/PRIVACY-MANAGER-CLIENT(24188): SocketClient.cpp: disconnect(72) > Client disconnected
06-02 23:37:40.596+0900 E/PKGMGR_CERT(24188): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-02 23:37:40.596+0900 E/PKGMGR_CERT(24188): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-02 23:37:40.606+0900 E/PKGMGR_CERT(24188): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-02 23:37:40.636+0900 E/rpm-installer(24188): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-02 23:37:40.646+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/ESD     (  894): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.646+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:40.656+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-02 23:37:40.656+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-02 23:37:40.656+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-02 23:37:41.837+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 23:37:42.327+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24188]
06-02 23:37:43.248+0900 E/PKGMGR  (24237): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-02 23:37:43.288+0900 E/PKGMGR_SERVER(24185): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-02 23:37:43.288+0900 E/PKGMGR_INFO(24185): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-02 23:37:43.298+0900 E/rpm-installer(24185): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-02 23:37:43.308+0900 E/PKGMGR_SERVER(24185): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-02 23:37:43.308+0900 E/PKGMGR  (24237): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[242370002]
06-02 23:37:43.428+0900 E/PKGMGR_INSTALLER(24239): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-02 23:37:43.428+0900 E/rpm-installer(24239): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-02 23:37:43.448+0900 E/rpm-installer(24239): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-02 23:37:43.448+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-02 23:37:43.448+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 23:37:43.448+0900 E/rpm-installer(24239): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-02 23:37:43.448+0900 E/rpm-installer(24239): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 23:37:43.509+0900 W/CERT_SVC_VCORE(24239): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-02 23:37:43.569+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-02 23:37:43.569+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.569+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-02 23:37:43.579+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.579+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:43.839+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-02 23:37:43.849+0900 E/rpm-installer(24239): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-02 23:37:43.859+0900 E/PKGMGR_PARSER(24239): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-02 23:37:43.859+0900 E/PKGMGR_PARSER(24239): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-02 23:37:43.899+0900 I/PRIVACY-MANAGER-CLIENT(24239): SocketClient.cpp: SocketClient(37) > Client created
06-02 23:37:44.099+0900 E/PKGMGR_PARSER(24239): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-02 23:37:44.119+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-02 23:37:44.119+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-02 23:37:44.119+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-02 23:37:44.119+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
06-02 23:37:44.129+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
06-02 23:37:44.129+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
06-02 23:37:44.129+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
06-02 23:37:44.129+0900 E/PKGMGR_CERT(24239): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-02 23:37:44.139+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-02 23:37:44.139+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
06-02 23:37:44.139+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.139+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.149+0900 E/rpm-installer(24239): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-02 23:37:44.169+0900 E/rpm-installer(24239): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-02 23:37:44.179+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-02 23:37:44.179+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:44.179+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:45.841+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-02 23:37:46.091+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-02 23:37:46.091+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-02 23:37:46.091+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-02 23:37:46.091+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-02 23:37:46.091+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-02 23:37:46.091+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-02 23:37:46.121+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.131+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-02 23:37:46.141+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-02 23:37:46.141+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-02 23:37:46.141+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: sighandler(417) > child NORMAL exit [24239]
06-02 23:37:46.151+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-02 23:37:46.151+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-02 23:37:46.151+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-02 23:37:46.151+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-02 23:37:46.151+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 23:37:46.171+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (840) > Enter.
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (703) > Exit.
06-02 23:37:46.171+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-02 23:37:46.171+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (131) > Enter
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-02 23:37:46.181+0900 I/Tizen::App( 1233): (883) > Exit.
06-02 23:37:46.191+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-02 23:37:47.843+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 23:37:47.843+0900 E/PKGMGR_SERVER(24185): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 23:37:50.255+0900 W/AUL     (24293): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 23:37:50.255+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 23:37:50.265+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 23:37:50.275+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 23:37:50.275+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 23:37:50.275+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 24293
06-02 23:37:50.275+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 23:37:50.285+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
06-02 23:37:50.285+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 23:37:50.285+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 23:37:50.285+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 23:37:50.285+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 23:37:50.305+0900 I/abc     (23171): abc
06-02 23:37:50.305+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: ui_app_main(789) > app_efl_main
06-02 23:37:50.305+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 23:37:50.335+0900 E/TBM     (23171): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 23:37:50.385+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 23171, appid: org.example.client
06-02 23:37:50.385+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 23:37:50.405+0900 W/AUL     (24293): launch.c: app_request_to_launchpad(425) > request cmd(0) result(23171)
06-02 23:37:50.635+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(514) > [APP 23171] Event: RESET State: CREATED
06-02 23:37:50.635+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 23:37:50.655+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.655+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.665+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.665+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.665+0900 E/EFL     (23171): edje<23171> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 23:37:50.665+0900 E/EFL     (23171): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 23:37:50.675+0900 W/APP_CORE(23171): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-02 23:37:50.675+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:50.675+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:50.675+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 23:37:50.686+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 23:37:50.686+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:50.696+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:50.696+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:37:50.796+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 23:37:50.796+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 23:37:50.796+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 23:37:50.796+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 23:37:50.796+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 23:37:50.796+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 23:37:50.796+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(23171) status(3)
06-02 23:37:50.806+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:37:50.806+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:37:50.806+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(23171)
06-02 23:37:50.806+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 23171, appid: org.example.client, status: fg
06-02 23:37:50.806+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(514) > [APP 23171] Event: RESUME State: CREATED
06-02 23:37:50.816+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 23:37:50.816+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 23:37:50.816+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 23:37:50.816+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 23:37:50.816+0900 I/APP_CORE(23171): appcore-efl.c: __do_app(625) > [APP 23171] Initial Launching, call the resume_cb
06-02 23:37:50.816+0900 I/CAPI_APPFW_APPLICATION(23171): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:37:51.166+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(23171) status(0)
06-02 23:37:51.436+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 23:37:51.436+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 23171.
06-02 23:37:51.456+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2746
06-02 23:37:52.017+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962869186
06-02 23:37:52.117+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962869285
06-02 23:37:52.237+0900 I/UXT     (24306): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 23:37:52.407+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962869575
06-02 23:37:52.407+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:52.507+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962869663
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: vconf_get_bool(2729) > vconf_get_bool(23171) : db/ise/keysound error
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 23:37:52.507+0900 E/VCONF   (23171): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 23:37:52.567+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:53.668+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962870830
06-02 23:37:53.668+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:53.769+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962870929
06-02 23:37:53.769+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:53.809+0900 D/basicui (23171): successed to load edc file
06-02 23:37:53.829+0900 E/EFL     (23171): elementary<23171> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007bfe1 into part 'swallow_content'
06-02 23:37:55.750+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=962872909
06-02 23:37:55.750+0900 I/MY_LOG  (23171): Button pressed
06-02 23:37:55.811+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 23:37:55.831+0900 E/EFL     (23171): ecore_x<23171> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=962872997
06-02 23:37:55.841+0900 I/MY_LOG  (23171): Button unpressed
06-02 23:37:55.981+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 23171 pgid = 23171
06-02 23:37:55.981+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(23171)
06-02 23:37:55.991+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 23:37:56.001+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 23:37:56.001+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 23:37:56.001+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 23:37:56.051+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 23:37:56.051+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 23:37:56.051+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[23171] terminate event is forwarded
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 23171, ]
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 23:37:56.051+0900 I/Tizen::App( 1233): (512) > Not registered pid(23171)
06-02 23:37:56.051+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 23:37:56.051+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:56.051+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 23171
06-02 23:37:56.061+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 23171
06-02 23:37:56.061+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 23171
06-02 23:37:56.061+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2750
06-02 23:37:56.071+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 23:37:56.081+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 23:37:56.081+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 23:37:56.081+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 23:37:56.081+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:56.081+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 23171.
06-02 23:37:56.081+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 23:37:56.121+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 23:37:56.131+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 23:37:56.131+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 23:37:56.151+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 23:37:56.171+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 23:37:56.171+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:37:56.181+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 23:37:56.181+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 23:37:56.181+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 23:37:56.191+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 23:37:56.201+0900 W/CRASH_MANAGER(24312): worker.c: worker_job(1199) > 0623171636c69149641427
