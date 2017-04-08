S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 1540
Date: 2017-04-06 05:48:08+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 1540, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000604
r2   = 0x00000006, r3   = 0xb40ab4c0
r4   = 0x00000002, r5   = 0xb40ab000
r6   = 0xb67a509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5ed3708
r10  = 0xb800f388, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbef49c2c
lr   = 0xb669bf18, pc   = 0xb669ab84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    340560 KB
Buffers:     36052 KB
Cached:     186320 KB
VmPeak:     133932 KB
VmSize:     133928 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28224 KB
VmRSS:       28224 KB
VmData:      45868 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1540 TID = 1540
1540 1585 1602 1607 1627 

Maps Information
aee4c000 af64b000 rw-p [stack:1627]
b0f50000 b0f61000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f71000 b0f76000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1378000 b1380000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1392000 b1b91000 rw-p [stack:1607]
b1b91000 b1b92000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba2000 b1bb6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bca000 b1bcb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bdb000 b1bde000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bef000 b1bf0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c00000 b1c02000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c12000 b1c14000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c24000 b1c34000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c44000 b1c50000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c62000 b2461000 rw-p [stack:1602]
b2792000 b2799000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ac000 b27b2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27c2000 b27de000 r-xp /opt/usr/apps/org.example.client/bin/client
b2937000 b2a1a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a51000 b2a79000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a8b000 b328a000 rw-p [stack:1585]
b328a000 b328c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b329c000 b32a6000 r-xp /lib/libnss_files-2.20-2014.11.so
b32b7000 b32c0000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d1000 b32e2000 r-xp /lib/libnsl-2.20-2014.11.so
b32f5000 b32fb000 r-xp /lib/libnss_compat-2.20-2014.11.so
b330c000 b330d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3335000 b333c000 r-xp /usr/lib/libminizip.so.1.0.0
b334c000 b3351000 r-xp /usr/lib/libstorage.so.0.1
b3361000 b33c0000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33d6000 b33ea000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33fa000 b343e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b344e000 b3456000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3466000 b3496000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34a9000 b3562000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3576000 b35c9000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35da000 b35f5000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3605000 b36c6000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36d9000 b36e9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36f9000 b3706000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3717000 b371e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b372e000 b376f000 r-xp /usr/lib/libmdm.so.1.2.12
b377f000 b3787000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3796000 b37a6000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37c7000 b3827000 r-xp /usr/lib/libasound.so.2.0.0
b3839000 b383c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b384c000 b384f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b385f000 b3864000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3874000 b3875000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3885000 b3890000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a4000 b38ab000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38bb000 b38c1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d1000 b38d6000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38e6000 b3901000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3911000 b3918000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3928000 b392b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b393c000 b396a000 r-xp /usr/lib/libidn.so.11.5.44
b397a000 b3990000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a1000 b39ab000 r-xp /usr/lib/libcares.so.2.1.0
b39bb000 b39c5000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39d5000 b39d7000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39e7000 b39e8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39f8000 b39fc000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a0d000 b3a35000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a46000 b3a6f000 r-xp /usr/lib/libturbojpeg.so
b3a8f000 b3a95000 r-xp /usr/lib/libgif.so.4.1.6
b3aa5000 b3aeb000 r-xp /usr/lib/libcurl.so.4.3.0
b3afc000 b3b1d000 r-xp /usr/lib/libexif.so.12.3.3
b3b38000 b3b4d000 r-xp /usr/lib/libtts.so
b3b5e000 b3b66000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b76000 b3c3c000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c5c000 b3d54000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d73000 b3e41000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e58000 b3e5a000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e6a000 b3e70000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e80000 b3ea3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eb4000 b3eb6000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ec6000 b3ec8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ed9000 b3ede000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ef5000 b3ef7000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f07000 b3f0e000 r-xp /usr/lib/libsensord-share.so
b3f1e000 b3f36000 r-xp /usr/lib/libsensor.so.1.1.0
b3f47000 b3f4a000 r-xp /usr/lib/libXv.so.1.0.0
b3f5a000 b3f5f000 r-xp /usr/lib/libutilX.so.1.1.0
b3f6f000 b3f74000 r-xp /usr/lib/libappcore-common.so.1.1
b3f84000 b3f8b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f9e000 b3fa2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fb3000 b4091000 r-xp /usr/lib/libCOREGL.so.4.0
b40b1000 b40b4000 r-xp /usr/lib/libuuid.so.1.3.0
b40c4000 b40db000 r-xp /usr/lib/libblkid.so.1.1.0
b40ec000 b40ee000 r-xp /usr/lib/libXau.so.6.0.0
b40fe000 b4145000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4157000 b415d000 r-xp /usr/lib/libjson-c.so.2.0.1
b416e000 b4172000 r-xp /usr/lib/libogg.so.0.7.1
b4182000 b41a4000 r-xp /usr/lib/libvorbis.so.0.4.3
b41b4000 b4298000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42b4000 b42b7000 r-xp /usr/lib/libEGL.so.1.4
b42c8000 b42ce000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42de000 b42e0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42f0000 b42fd000 r-xp /usr/lib/libGLESv2.so.2.0
b430e000 b4370000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4385000 b439d000 r-xp /usr/lib/libmount.so.1.1.0
b43af000 b43c3000 r-xp /usr/lib/libxcb.so.1.1.0
b43d3000 b43da000 r-xp /lib/libcrypt-2.20-2014.11.so
b4412000 b4414000 r-xp /usr/lib/libiri.so
b4424000 b442f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4440000 b4476000 r-xp /usr/lib/libpulse.so.0.16.2
b4487000 b44ca000 r-xp /usr/lib/libsndfile.so.1.0.25
b44df000 b44f4000 r-xp /lib/libexpat.so.1.5.2
b4506000 b45c4000 r-xp /usr/lib/libcairo.so.2.11200.14
b45d8000 b45e0000 r-xp /usr/lib/libdrm.so.2.4.0
b45f0000 b45f3000 r-xp /usr/lib/libdri2.so.0.0.0
b4603000 b4651000 r-xp /usr/lib/libssl.so.1.0.0
b4666000 b4672000 r-xp /usr/lib/libeeze.so.1.13.0
b4683000 b468c000 r-xp /usr/lib/libethumb.so.1.13.0
b469c000 b469f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46af000 b4866000 r-xp /usr/lib/libcrypto.so.1.0.0
b5651000 b565a000 r-xp /usr/lib/libXi.so.6.1.0
b566a000 b566c000 r-xp /usr/lib/libXgesture.so.7.0.0
b567c000 b5680000 r-xp /usr/lib/libXtst.so.6.1.0
b5690000 b5696000 r-xp /usr/lib/libXrender.so.1.3.0
b56a6000 b56ac000 r-xp /usr/lib/libXrandr.so.2.2.0
b56bc000 b56be000 r-xp /usr/lib/libXinerama.so.1.0.0
b56cf000 b56d2000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e2000 b56ed000 r-xp /usr/lib/libXext.so.6.4.0
b56fd000 b56ff000 r-xp /usr/lib/libXdamage.so.1.1.0
b570f000 b5711000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5721000 b5803000 r-xp /usr/lib/libX11.so.6.3.0
b5817000 b581e000 r-xp /usr/lib/libXcursor.so.1.0.2
b582e000 b5846000 r-xp /usr/lib/libudev.so.1.6.0
b5848000 b584b000 r-xp /lib/libattr.so.1.1.0
b585b000 b587b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b587c000 b5881000 r-xp /usr/lib/libffi.so.6.0.2
b5892000 b58aa000 r-xp /lib/libz.so.1.2.8
b58ba000 b58bc000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58cc000 b59a1000 r-xp /usr/lib/libxml2.so.2.9.2
b59b6000 b5a51000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a6d000 b5a70000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a80000 b5a99000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aaa000 b5abb000 r-xp /lib/libresolv-2.20-2014.11.so
b5acf000 b5b49000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b5e000 b5b60000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b70000 b5b77000 r-xp /usr/lib/libembryo.so.1.13.0
b5b87000 b5b91000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba2000 b5bba000 r-xp /usr/lib/libpng12.so.0.50.0
b5bcb000 b5bee000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c0f000 b5c23000 r-xp /usr/lib/libector.so.1.13.0
b5c34000 b5c4c000 r-xp /usr/lib/liblua-5.1.so
b5c5d000 b5cb4000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cc8000 b5cf0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d01000 b5d14000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d25000 b5d5f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d70000 b5d7e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d8e000 b5d96000 r-xp /usr/lib/libtbm.so.1.0.0
b5da6000 b5db3000 r-xp /usr/lib/libeio.so.1.13.0
b5dc3000 b5dc5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dd5000 b5dda000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dea000 b5e01000 r-xp /usr/lib/libefreet.so.1.13.0
b5e13000 b5e33000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e43000 b5e63000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e65000 b5e6b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e7b000 b5e8c000 r-xp /usr/lib/libemotion.so.1.13.0
b5e9d000 b5ea4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb4000 b5ec3000 r-xp /usr/lib/libeo.so.1.13.0
b5ed4000 b5ee6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ef7000 b5efc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f0c000 b5f25000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f35000 b5f52000 r-xp /usr/lib/libeet.so.1.13.0
b5f6b000 b5fb3000 r-xp /usr/lib/libeina.so.1.13.0
b5fc4000 b5fd4000 r-xp /usr/lib/libefl.so.1.13.0
b5fe5000 b60ca000 r-xp /usr/lib/libicuuc.so.51.1
b60e7000 b6227000 r-xp /usr/lib/libicui18n.so.51.1
b623e000 b6276000 r-xp /usr/lib/libecore_x.so.1.13.0
b6288000 b628b000 r-xp /lib/libcap.so.2.21
b629b000 b62c4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62d5000 b62dc000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ee000 b6325000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6336000 b6421000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6434000 b64ad000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64bf000 b64c4000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d4000 b64de000 r-xp /usr/lib/libvconf.so.0.2.45
b64ee000 b64f0000 r-xp /usr/lib/libvasum.so.0.3.1
b6500000 b6502000 r-xp /usr/lib/libttrace.so.1.1
b6512000 b6515000 r-xp /usr/lib/libiniparser.so.0
b6525000 b654b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b655b000 b6560000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6571000 b6588000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6599000 b6604000 r-xp /lib/libm-2.20-2014.11.so
b6615000 b661b000 r-xp /lib/librt-2.20-2014.11.so
b662c000 b6639000 r-xp /usr/lib/libunwind.so.8.0.1
b666f000 b6793000 r-xp /lib/libc-2.20-2014.11.so
b67a8000 b67c1000 r-xp /lib/libgcc_s-4.9.so.1
b67d1000 b68b3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c4000 b68ee000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ff000 b693b000 r-xp /usr/lib/libsystemd.so.0.4.0
b693d000 b69c0000 r-xp /usr/lib/libedje.so.1.13.0
b69d3000 b69f1000 r-xp /usr/lib/libecore.so.1.13.0
b6a11000 b6b98000 r-xp /usr/lib/libevas.so.1.13.0
b6bcd000 b6be1000 r-xp /lib/libpthread-2.20-2014.11.so
b6bf5000 b6e29000 r-xp /usr/lib/libelementary.so.1.13.0
b6e58000 b6e5c000 r-xp /usr/lib/libsmack.so.1.0.0
b6e6c000 b6e73000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e83000 b6e85000 r-xp /usr/lib/libdlog.so.0.0.0
b6e95000 b6e98000 r-xp /usr/lib/libbundle.so.0.1.22
b6ea8000 b6eaa000 r-xp /lib/libdl-2.20-2014.11.so
b6ebb000 b6ed3000 r-xp /usr/lib/libaul.so.0.1.0
b6ee7000 b6eec000 r-xp /usr/lib/libappcore-efl.so.1.1
b6efd000 b6f0a000 r-xp /usr/lib/liblptcp.so
b6f1c000 b6f20000 r-xp /usr/lib/libsys-assert.so
b6f31000 b6f51000 r-xp /lib/ld-2.20-2014.11.so
b6f62000 b6f67000 r-xp /usr/bin/launchpad-loader
b7c8a000 b806b000 rw-p [heap]
bef2a000 bef4b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1540)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb669ab84) [/lib/libc.so.6] + 0x2bb84
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
MD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.514+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.514+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.514+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(1540) status(0)
04-06 05:48:06.534+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.534+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.544+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.554+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.554+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.554+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.554+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.564+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.564+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.574+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.574+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.584+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.584+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.594+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.604+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.604+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.604+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.604+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.614+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.614+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.644+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.644+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.754+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.764+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.764+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.774+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.774+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.774+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.774+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.784+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.784+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.804+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.814+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.814+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.814+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.824+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.834+0900 I/CAPI_APPFW_APPLICATION( 1609): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:48:06.834+0900 D/callerid_service( 1609): service_app_create
04-06 05:48:06.834+0900 D/callerid_service( 1609): tcid_init_telephony
04-06 05:48:06.834+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.834+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.834+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.834+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.844+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.844+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.854+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.854+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.864+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.864+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.874+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.884+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.884+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.884+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.884+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.894+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.894+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.914+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.914+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.924+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.924+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.934+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.944+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.944+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.944+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.944+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.944+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:06.944+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:06.964+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:06.964+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:06.964+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:06.964+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:06.974+0900 D/callerid_service( 1609): Setting call state notification callback.
04-06 05:48:06.974+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:06.974+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:06.974+0900 I/CAPI_TELEPHONY( 1609): telephony_common.c: telephony_set_noti_cb(328) > Entry
04-06 05:48:06.984+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.984+0900 D/callerid_service( 1609): Setting call state notification callback.
04-06 05:48:06.984+0900 I/CAPI_TELEPHONY( 1609): telephony_common.c: telephony_set_noti_cb(328) > Entry
04-06 05:48:06.994+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:06.994+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:06.994+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:06.994+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:06.994+0900 D/callerid_service( 1609): sprdmodem0
04-06 05:48:06.994+0900 D/callerid_service( 1609): sprdmodem1
04-06 05:48:06.994+0900 D/callerid_service( 1609): Found 2 cps
04-06 05:48:06.994+0900 D/callerid_service( 1609): Initializing handle for cp sprdmodem0
04-06 05:48:06.994+0900 D/callerid_service( 1609): Initializing handle for cp sprdmodem1
04-06 05:48:06.994+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.004+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.014+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.014+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.024+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.024+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.024+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.034+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.034+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.034+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.034+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.044+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.044+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.054+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.054+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.054+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.054+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.064+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.064+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.074+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.084+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.084+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.084+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.084+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.094+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.094+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.104+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.104+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.104+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.104+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.114+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.114+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.124+0900 D/callerid_service( 1609): CALLER ID Service Started Successfully
04-06 05:48:07.124+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.134+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.134+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.134+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.134+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.144+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.144+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.164+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.164+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.164+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.174+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.174+0900 I/UXT     ( 1621): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:48:07.174+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.184+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.184+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.184+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.184+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.194+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.194+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.204+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.204+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.214+0900 E/TBM     ( 1609): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:48:07.214+0900 I/MALI    ( 1609): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=1609   open drm_fd=37 
04-06 05:48:07.214+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.224+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.234+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.234+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.234+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.234+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.234+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.244+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.244+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.254+0900 W/AUL_AMD (  610): amd_main.c: __initializing_popup_handler(499) > [Info]__initializing_popup_handler
04-06 05:48:07.254+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.254+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.254+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.254+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.264+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.264+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.274+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.284+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.284+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.284+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.284+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.284+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.284+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.304+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.304+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.314+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.314+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.314+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.324+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.324+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.324+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.324+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.334+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.334+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.344+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.344+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.344+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.344+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.354+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.354+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.364+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.375+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.375+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.375+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.375+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.375+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.385+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.395+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.395+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.405+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.405+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.415+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.425+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.425+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.425+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.425+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.425+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.425+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.445+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.445+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.445+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.445+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.455+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.455+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.455+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.465+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.465+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.465+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.465+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.475+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.475+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.495+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.495+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.505+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.505+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.515+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.525+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.525+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.525+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.525+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.535+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.535+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.545+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.545+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.545+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.545+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.555+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.555+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.565+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.575+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.575+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.575+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.575+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.585+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.585+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.595+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.595+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.595+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.595+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.605+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.605+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.615+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.615+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.615+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.615+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.615+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.625+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.625+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.635+0900 I/APP_CORE( 1609): appcore-efl.c: __do_app(514) > [APP 1609] Event: RESET State: CREATED
04-06 05:48:07.635+0900 I/CAPI_APPFW_APPLICATION( 1609): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:48:07.635+0900 D/callerid_service( 1609): BEGIN: service_app_control
04-06 05:48:07.635+0900 D/callerid_service( 1609): callerid_service built at Sep 15 2015 11:07:23
04-06 05:48:07.635+0900 D/callerid_service( 1609): Unknown operation requested: http://tizen.org/appcontrol/operation/default
04-06 05:48:07.635+0900 D/callerid_service( 1609): END: service_app_control
04-06 05:48:07.645+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.645+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.645+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.645+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.645+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.655+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.655+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.665+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.665+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.665+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.665+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.675+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.675+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.685+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.685+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.695+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.695+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.705+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.715+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.715+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.715+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.715+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.725+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.725+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.735+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.735+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.745+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:07.745+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:07.745+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.755+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:07.755+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:07.755+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:07.755+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:07.765+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:07.765+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:07.775+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:07.775+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:07.775+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:48:07.785+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.785+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.855+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.855+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.905+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.905+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:07.955+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:07.955+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.005+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.005+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.045+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.045+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.095+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.095+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.095+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.105+0900 E/EFL     ( 1540): ecore_x<1540> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=45211
04-06 05:48:08.105+0900 I/MY_LOG  ( 1540): Button pressed
04-06 05:48:08.105+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.105+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.105+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.105+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.115+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.115+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:08.125+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.125+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.125+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:08.125+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:08.135+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.135+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.145+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.155+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.155+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.155+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.155+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.165+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.165+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:08.185+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.185+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.185+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:08.185+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:08.195+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.195+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.195+0900 E/EFL     ( 1540): ecore_x<1540> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=45299
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf.c: vconf_get_bool(2729) > vconf_get_bool(1540) : db/ise/keysound error
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:48:08.195+0900 E/VCONF   ( 1540): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:48:08.205+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.215+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.215+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.215+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.215+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.215+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.215+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:08.235+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.235+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.235+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:08.235+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:08.245+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.245+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.245+0900 I/MY_LOG  ( 1540): Button unpressed
04-06 05:48:08.255+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.265+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.265+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.265+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.265+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.265+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.265+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:08.285+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.285+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.285+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:08.285+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:08.285+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.285+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.295+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.305+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.305+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.305+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.305+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.315+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.315+0900 W/AUL_AMD (  610): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 7, pid: 1412
04-06 05:48:08.325+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:48:08.325+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-06 05:48:08.335+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(1412), cmd(7)
04-06 05:48:08.335+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(425) > request cmd(7) result(1412)
04-06 05:48:08.335+0900 W/AUL     ( 1229): launch.c: app_request_to_launchpad(396) > request cmd(7) to(com.samsung.samsung-log-relay-mobile-service)
04-06 05:48:08.335+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 7
04-06 05:48:08.345+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.355+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/samsung-log-service, ret : 0
04-06 05:48:08.355+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:48:08.355+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1229
04-06 05:48:08.355+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:48:08.365+0900 W/AUL     (  610): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 1412, appid: com.samsung.samsung-log-relay-mobile-service
04-06 05:48:08.365+0900 W/CRASH_MANAGER(  928): worker.c: worker_job(1199) > 0601540636c69149142528
