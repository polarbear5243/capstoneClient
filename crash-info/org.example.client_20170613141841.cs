S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20795
Date: 2017-06-13 14:18:41+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20795, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000513b
r2   = 0x00000006, r3   = 0xb404b4c0
r4   = 0x00000002, r5   = 0xb404b000
r6   = 0xb674509c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb7549238
r10  = 0xbe91f498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe91f0ec
lr   = 0xb663bf18, pc   = 0xb663ab84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     50464 KB
Buffers:     66404 KB
Cached:     240748 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19636 KB
VmRSS:       19636 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20795 TID = 20795
20795 20799 20852 20853 

Maps Information
b1314000 b131c000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b132e000 b1b2d000 rw-p [stack:20853]
b1b2d000 b1b2e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b3e000 b1b52000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b66000 b1b67000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b77000 b1b7a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b8b000 b1b8c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b9c000 b1b9e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bae000 b1bb0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bc0000 b1bd0000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1be0000 b1bec000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1bfe000 b23fd000 rw-p [stack:20852]
b272e000 b2735000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2748000 b274e000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b275e000 b278e000 r-xp /opt/usr/apps/org.example.client/bin/client
b28d7000 b29ba000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29f1000 b2a19000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a2b000 b322a000 rw-p [stack:20799]
b322a000 b322c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b323c000 b3246000 r-xp /lib/libnss_files-2.20-2014.11.so
b3257000 b3260000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3271000 b3282000 r-xp /lib/libnsl-2.20-2014.11.so
b3295000 b329b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ac000 b32ad000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32d5000 b32dc000 r-xp /usr/lib/libminizip.so.1.0.0
b32ec000 b32f1000 r-xp /usr/lib/libstorage.so.0.1
b3301000 b3360000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3376000 b338a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b339a000 b33de000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33ee000 b33f6000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3406000 b3436000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3449000 b3502000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3516000 b3569000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b357a000 b3595000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35a5000 b3666000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3679000 b3689000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3699000 b36a6000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36b7000 b36be000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36ce000 b370f000 r-xp /usr/lib/libmdm.so.1.2.12
b371f000 b3727000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3736000 b3746000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3767000 b37c7000 r-xp /usr/lib/libasound.so.2.0.0
b37d9000 b37dc000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37ec000 b37ef000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b37ff000 b3804000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3814000 b3815000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3825000 b3830000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3844000 b384b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b385b000 b3861000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3871000 b3876000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3886000 b38a1000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38b1000 b38b8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38c8000 b38cb000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38dc000 b390a000 r-xp /usr/lib/libidn.so.11.5.44
b391a000 b3930000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3941000 b394b000 r-xp /usr/lib/libcares.so.2.1.0
b395b000 b3965000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3975000 b3977000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3987000 b3988000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3998000 b399c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39ad000 b39d5000 r-xp /usr/lib/libui-extension.so.0.1.0
b39e6000 b3a0f000 r-xp /usr/lib/libturbojpeg.so
b3a2f000 b3a35000 r-xp /usr/lib/libgif.so.4.1.6
b3a45000 b3a8b000 r-xp /usr/lib/libcurl.so.4.3.0
b3a9c000 b3abd000 r-xp /usr/lib/libexif.so.12.3.3
b3ad8000 b3aed000 r-xp /usr/lib/libtts.so
b3afe000 b3b06000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b16000 b3bdc000 r-xp /usr/lib/libdali-core.so.0.0.0
b3bfc000 b3cf4000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d13000 b3de1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3df8000 b3dfa000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e0a000 b3e10000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e20000 b3e43000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e54000 b3e56000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e66000 b3e68000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e79000 b3e7e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e95000 b3e97000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ea7000 b3eae000 r-xp /usr/lib/libsensord-share.so
b3ebe000 b3ed6000 r-xp /usr/lib/libsensor.so.1.1.0
b3ee7000 b3eea000 r-xp /usr/lib/libXv.so.1.0.0
b3efa000 b3eff000 r-xp /usr/lib/libutilX.so.1.1.0
b3f0f000 b3f14000 r-xp /usr/lib/libappcore-common.so.1.1
b3f24000 b3f2b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f3e000 b3f42000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f53000 b4031000 r-xp /usr/lib/libCOREGL.so.4.0
b4051000 b4054000 r-xp /usr/lib/libuuid.so.1.3.0
b4064000 b407b000 r-xp /usr/lib/libblkid.so.1.1.0
b408c000 b408e000 r-xp /usr/lib/libXau.so.6.0.0
b409e000 b40e5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40f7000 b40fd000 r-xp /usr/lib/libjson-c.so.2.0.1
b410e000 b4112000 r-xp /usr/lib/libogg.so.0.7.1
b4122000 b4144000 r-xp /usr/lib/libvorbis.so.0.4.3
b4154000 b4238000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4254000 b4257000 r-xp /usr/lib/libEGL.so.1.4
b4268000 b426e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b427e000 b4280000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4290000 b429d000 r-xp /usr/lib/libGLESv2.so.2.0
b42ae000 b4310000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4325000 b433d000 r-xp /usr/lib/libmount.so.1.1.0
b434f000 b4363000 r-xp /usr/lib/libxcb.so.1.1.0
b4373000 b437a000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b2000 b43b4000 r-xp /usr/lib/libiri.so
b43c4000 b43cf000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43e0000 b4416000 r-xp /usr/lib/libpulse.so.0.16.2
b4427000 b446a000 r-xp /usr/lib/libsndfile.so.1.0.25
b447f000 b4494000 r-xp /lib/libexpat.so.1.5.2
b44a6000 b4564000 r-xp /usr/lib/libcairo.so.2.11200.14
b4578000 b4580000 r-xp /usr/lib/libdrm.so.2.4.0
b4590000 b4593000 r-xp /usr/lib/libdri2.so.0.0.0
b45a3000 b45f1000 r-xp /usr/lib/libssl.so.1.0.0
b4606000 b4612000 r-xp /usr/lib/libeeze.so.1.13.0
b4623000 b462c000 r-xp /usr/lib/libethumb.so.1.13.0
b463c000 b463f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b464f000 b4806000 r-xp /usr/lib/libcrypto.so.1.0.0
b55f1000 b55fa000 r-xp /usr/lib/libXi.so.6.1.0
b560a000 b560c000 r-xp /usr/lib/libXgesture.so.7.0.0
b561c000 b5620000 r-xp /usr/lib/libXtst.so.6.1.0
b5630000 b5636000 r-xp /usr/lib/libXrender.so.1.3.0
b5646000 b564c000 r-xp /usr/lib/libXrandr.so.2.2.0
b565c000 b565e000 r-xp /usr/lib/libXinerama.so.1.0.0
b566f000 b5672000 r-xp /usr/lib/libXfixes.so.3.1.0
b5682000 b568d000 r-xp /usr/lib/libXext.so.6.4.0
b569d000 b569f000 r-xp /usr/lib/libXdamage.so.1.1.0
b56af000 b56b1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56c1000 b57a3000 r-xp /usr/lib/libX11.so.6.3.0
b57b7000 b57be000 r-xp /usr/lib/libXcursor.so.1.0.2
b57ce000 b57e6000 r-xp /usr/lib/libudev.so.1.6.0
b57e8000 b57eb000 r-xp /lib/libattr.so.1.1.0
b57fb000 b581b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b581c000 b5821000 r-xp /usr/lib/libffi.so.6.0.2
b5832000 b584a000 r-xp /lib/libz.so.1.2.8
b585a000 b585c000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b586c000 b5941000 r-xp /usr/lib/libxml2.so.2.9.2
b5956000 b59f1000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a0d000 b5a10000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a20000 b5a39000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a4a000 b5a5b000 r-xp /lib/libresolv-2.20-2014.11.so
b5a6f000 b5ae9000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5afe000 b5b00000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b10000 b5b17000 r-xp /usr/lib/libembryo.so.1.13.0
b5b27000 b5b31000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b42000 b5b5a000 r-xp /usr/lib/libpng12.so.0.50.0
b5b6b000 b5b8e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5baf000 b5bc3000 r-xp /usr/lib/libector.so.1.13.0
b5bd4000 b5bec000 r-xp /usr/lib/liblua-5.1.so
b5bfd000 b5c54000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c68000 b5c90000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca1000 b5cb4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cc5000 b5cff000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d10000 b5d1e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d2e000 b5d36000 r-xp /usr/lib/libtbm.so.1.0.0
b5d46000 b5d53000 r-xp /usr/lib/libeio.so.1.13.0
b5d63000 b5d65000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d75000 b5d7a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d8a000 b5da1000 r-xp /usr/lib/libefreet.so.1.13.0
b5db3000 b5dd3000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de3000 b5e03000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e05000 b5e0b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e1b000 b5e2c000 r-xp /usr/lib/libemotion.so.1.13.0
b5e3d000 b5e44000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e54000 b5e63000 r-xp /usr/lib/libeo.so.1.13.0
b5e74000 b5e86000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e97000 b5e9c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eac000 b5ec5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ed5000 b5ef2000 r-xp /usr/lib/libeet.so.1.13.0
b5f0b000 b5f53000 r-xp /usr/lib/libeina.so.1.13.0
b5f64000 b5f74000 r-xp /usr/lib/libefl.so.1.13.0
b5f85000 b606a000 r-xp /usr/lib/libicuuc.so.51.1
b6087000 b61c7000 r-xp /usr/lib/libicui18n.so.51.1
b61de000 b6216000 r-xp /usr/lib/libecore_x.so.1.13.0
b6228000 b622b000 r-xp /lib/libcap.so.2.21
b623b000 b6264000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6275000 b627c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b628e000 b62c5000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62d6000 b63c1000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63d4000 b644d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b645f000 b6464000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6474000 b647e000 r-xp /usr/lib/libvconf.so.0.2.45
b648e000 b6490000 r-xp /usr/lib/libvasum.so.0.3.1
b64a0000 b64a2000 r-xp /usr/lib/libttrace.so.1.1
b64b2000 b64b5000 r-xp /usr/lib/libiniparser.so.0
b64c5000 b64eb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b64fb000 b6500000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6511000 b6528000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6539000 b65a4000 r-xp /lib/libm-2.20-2014.11.so
b65b5000 b65bb000 r-xp /lib/librt-2.20-2014.11.so
b65cc000 b65d9000 r-xp /usr/lib/libunwind.so.8.0.1
b660f000 b6733000 r-xp /lib/libc-2.20-2014.11.so
b6748000 b6761000 r-xp /lib/libgcc_s-4.9.so.1
b6771000 b6853000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6864000 b688e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b689f000 b68db000 r-xp /usr/lib/libsystemd.so.0.4.0
b68dd000 b6960000 r-xp /usr/lib/libedje.so.1.13.0
b6973000 b6991000 r-xp /usr/lib/libecore.so.1.13.0
b69b1000 b6b38000 r-xp /usr/lib/libevas.so.1.13.0
b6b6d000 b6b81000 r-xp /lib/libpthread-2.20-2014.11.so
b6b95000 b6dc9000 r-xp /usr/lib/libelementary.so.1.13.0
b6df8000 b6dfc000 r-xp /usr/lib/libsmack.so.1.0.0
b6e0c000 b6e13000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e23000 b6e25000 r-xp /usr/lib/libdlog.so.0.0.0
b6e35000 b6e38000 r-xp /usr/lib/libbundle.so.0.1.22
b6e48000 b6e4a000 r-xp /lib/libdl-2.20-2014.11.so
b6e5b000 b6e73000 r-xp /usr/lib/libaul.so.0.1.0
b6e87000 b6e8c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e9d000 b6eaa000 r-xp /usr/lib/liblptcp.so
b6ebc000 b6ec0000 r-xp /usr/lib/libsys-assert.so
b6ed1000 b6ef1000 r-xp /lib/ld-2.20-2014.11.so
b6f02000 b6f07000 r-xp /usr/bin/launchpad-loader
b74e0000 b7725000 rw-p [heap]
be8ff000 be920000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20795)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb663ab84) [/lib/libc.so.6] + 0x2bb84
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
 package manager server start
06-13 14:18:25.485+0900 E/PKGMGR_SERVER(20712): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:18:25.495+0900 E/PKGMGR_INFO(20712): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:18:25.505+0900 E/rpm-installer(20712): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:18:25.505+0900 E/PKGMGR_SERVER(20712): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:18:25.515+0900 E/PKGMGR  (20710): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[207100002]
06-13 14:18:25.635+0900 E/PKGMGR_INSTALLER(20715): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:18:25.635+0900 E/rpm-installer(20715): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:18:25.645+0900 E/rpm-installer(20715): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:18:25.645+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:18:25.655+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:25.655+0900 E/rpm-installer(20715): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:18:25.655+0900 E/rpm-installer(20715): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:18:25.756+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:18:25.756+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-13 14:18:25.756+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.756+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 14:18:25.766+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.766+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.036+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:18:26.046+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:18:26.056+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:18:26.086+0900 I/PRIVACY-MANAGER-CLIENT(20715): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:18:26.296+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:18:26.316+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:18:26.316+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:18:26.336+0900 E/rpm-installer(20715): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:18:26.336+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:18:26.336+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 14:18:26.346+0900 E/rpm-installer(20715): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:18:26.366+0900 E/rpm-installer(20715): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 14:18:26.376+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.376+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:27.798+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:18:28.228+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:28.228+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:28.238+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:18:28.238+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:18:28.248+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:18:28.248+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20715]
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:18:28.258+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 14:18:28.268+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:18:28.268+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:18:28.268+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:18:28.268+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:18:28.288+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:18:28.318+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:18:29.789+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:18:29.789+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:18:30.460+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-13 14:18:32.522+0900 W/AUL     (20770): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:18:32.522+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:32.532+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:18:32.542+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:18:32.542+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:18:32.542+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 20770
06-13 14:18:32.542+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:18:32.552+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:18:32.552+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:32.552+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:32.552+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:32.552+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:32.572+0900 I/abc     (20283): abc
06-13 14:18:32.572+0900 I/CAPI_APPFW_APPLICATION(20283): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:32.572+0900 I/CAPI_APPFW_APPLICATION(20283): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:32.602+0900 E/TBM     (20283): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:32.652+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20283, appid: org.example.client
06-13 14:18:32.662+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:32.672+0900 W/AUL     (20770): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20283)
06-13 14:18:32.862+0900 W/CRASH_MANAGER(20783): worker.c: worker_job(1199) > 0620283636c691497331112
06-13 14:18:33.663+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:33.663+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-13 14:18:33.683+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20283 pgid = 20283
06-13 14:18:33.683+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20283)
06-13 14:18:33.693+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 20283.
06-13 14:18:33.693+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2020
06-13 14:18:33.723+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:18:33.723+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:18:33.723+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:18:33.733+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 20283.
06-13 14:18:33.733+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20283
06-13 14:18:33.733+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20283
06-13 14:18:33.733+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20283
06-13 14:18:33.733+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2021
06-13 14:18:34.484+0900 I/UXT     (20795): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:18:36.756+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:18:36.756+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:18:36.756+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18102964
06-13 14:18:36.756+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:18:36.756+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18102964
06-13 14:18:36.756+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:18:36.756+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:36.776+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:36.776+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
06-13 14:18:37.057+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:18:37.067+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:18:37.067+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:18:37.067+0900 E/STARTER (  721): )
06-13 14:18:37.067+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:18:37.067+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:18:37.067+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:18:37.067+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:18:37.077+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:37.077+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:18:37.077+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:18:37.077+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:18:37.077+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:18:37.087+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:37.097+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:37.097+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:37.097+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:37.107+0900 E/CAPI_APPFW_APPLICATION(20294): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:37.107+0900 E/CAPI_APPFW_APPLICATION(20294): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:37.107+0900 E/CAPI_APPFW_APPLICATION(20294): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:37.107+0900 E/CAPI_APPFW_APPLICATION(20294): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:37.107+0900 E/CAPI_APPFW_APPLICATION(20294): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:18:37.107+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:37.117+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:37.197+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20294, appid: com.samsung.task-mgr
06-13 14:18:37.197+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:37.197+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:18:37.197+0900 W/TASK_MGR_LITE(20294): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:18:37.207+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20294)
06-13 14:18:37.217+0900 I/GXT_SIB (20294): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:18:37.247+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:37.247+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:37.297+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:37.297+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:37.297+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:37.327+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:18:37.327+0900 E/RUA     (20294): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:18:37.327+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:18:37.337+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:18:37.337+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:18:37.397+0900 I/APP_CORE(20294): appcore-efl.c: __do_app(514) > [APP 20294] Event: RESET State: CREATED
06-13 14:18:37.397+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:18:37.397+0900 E/EFL     (20294): edje<20294> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:37.397+0900 E/EFL     (20294): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:37.397+0900 E/EFL     (20294): edje<20294> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:37.397+0900 E/EFL     (20294): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:37.407+0900 W/APP_CORE(20294): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:18:37.407+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:18:37.517+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:18:37.517+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:37.517+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:18:37.527+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:18:37.527+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:18:37.527+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:18:37.527+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(20294) status(3)
06-13 14:18:37.527+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:37.527+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:37.527+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(20294)
06-13 14:18:37.527+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20294, appid: com.samsung.task-mgr, status: fg
06-13 14:18:37.537+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:37.537+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:37.537+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:37.547+0900 I/APP_CORE(20294): appcore-efl.c: __do_app(514) > [APP 20294] Event: RESUME State: CREATED
06-13 14:18:37.557+0900 I/APP_CORE(20294): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:18:37.557+0900 I/APP_CORE(20294): appcore-efl.c: __do_app(625) > [APP 20294] Initial Launching, call the resume_cb
06-13 14:18:37.557+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:37.877+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(20294) status(0)
06-13 14:18:37.907+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18104109
06-13 14:18:37.907+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18104109
06-13 14:18:37.907+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:18:37.907+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:18:37.907+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:18:37.907+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:18:37.907+0900 E/STARTER (  721): )
06-13 14:18:37.907+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:18:37.907+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:18:37.907+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:18:37.907+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:18:38.208+0900 E/EFL     (20294): ecore_x<20294> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18104411
06-13 14:18:38.238+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2025
06-13 14:18:38.238+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:18:38.238+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 20294.
06-13 14:18:38.318+0900 E/EFL     (20294): ecore_x<20294> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18104532
06-13 14:18:38.818+0900 E/EFL     (20294): ecore_x<20294> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18105036
06-13 14:18:38.908+0900 E/EFL     (20294): ecore_x<20294> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18105125
06-13 14:18:39.028+0900 I/UXT     (20815): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:18:39.089+0900 E/TBM     (20815): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:39.089+0900 I/MALI    (20815): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=20815   open drm_fd=30 
06-13 14:18:39.219+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:18:39.219+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:18:39.219+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(20294)
06-13 14:18:39.219+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20294, appid: com.samsung.task-mgr, status: bg
06-13 14:18:39.219+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:39.219+0900 W/TASK_MGR_LITE(20294): task-mgr-lite.c: _pause_app(406) > 
06-13 14:18:39.219+0900 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/EFL     (20815): edje<20815> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:18:39.229+0900 E/EFL     (20815): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:18:39.229+0900 E/TASK_MGR_LITE(20294): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:18:39.239+0900 E/TASK_MGR_LITE(20294): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:18:39.249+0900 E/APP_CORE(20294): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:18:39.249+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:39.259+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:39.259+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:18:39.259+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:18:39.279+0900 I/MALI    (20294): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=20294   close drm_fd=29 
06-13 14:18:39.289+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:18:39.319+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:39.329+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:18:39.329+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:39.329+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:18:39.339+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:39.339+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:39.349+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.349+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.349+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.359+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18105512
06-13 14:18:39.359+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18105556
06-13 14:18:39.359+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:18:39.359+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:18:39.359+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:39.359+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:39.369+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:39.379+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.379+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:39.379+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:39.379+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:39.379+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:39.529+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18105703
06-13 14:18:39.529+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:18:39.529+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18105743
06-13 14:18:39.529+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:39.539+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.579+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:39.579+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:39.579+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:39.589+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 20294 pgid = 20294
06-13 14:18:39.589+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(20294)
06-13 14:18:39.589+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.589+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:39.629+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:18:39.629+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:18:39.629+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:18:39.639+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20294
06-13 14:18:39.639+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 20294
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[20294] terminate event is forwarded
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 20294, ]
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:18:39.639+0900 I/Tizen::App( 1175): (512) > Not registered pid(20294)
06-13 14:18:39.639+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:18:39.639+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:39.639+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20294
06-13 14:18:39.649+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:39.649+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 20294.
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:18:39.719+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnFocusedViewChanged(4344) >  view type is not chaged,same view[0]
06-13 14:18:39.739+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:39.739+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:39.739+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:39.749+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2028
06-13 14:18:39.759+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:39.759+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.170+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18106383
06-13 14:18:40.190+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:18:40.190+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:18:40.200+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:18:40.200+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:18:40.200+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: bg
06-13 14:18:40.290+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18106504
06-13 14:18:40.750+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.760+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.780+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.780+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.800+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.810+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.820+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.830+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.850+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.850+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.860+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.860+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.870+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.880+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.880+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.890+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.890+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.900+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.910+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.920+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.930+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18107144
06-13 14:18:40.940+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.940+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.950+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.950+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:40.970+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:40.970+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:41.010+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18107221
06-13 14:18:41.010+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:18:41.010+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:18:41.010+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:18:41.020+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:18:41.020+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:41.030+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:41.030+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:41.030+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:41.040+0900 I/abc     (20795): abc
06-13 14:18:41.040+0900 I/CAPI_APPFW_APPLICATION(20795): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:41.040+0900 I/CAPI_APPFW_APPLICATION(20795): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:41.070+0900 E/TBM     (20795): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:41.131+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20795, appid: org.example.client
06-13 14:18:41.131+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:41.141+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(20795)
06-13 14:18:41.261+0900 W/CRASH_MANAGER(20783): worker.c: worker_job(1199) > 0620795636c69149733112
